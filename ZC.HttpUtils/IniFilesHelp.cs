using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace ZC.HttpUtils
{
    public class IniFilesHelp
    {
        public static IniFilesHelp Ini = new IniFilesHelp();

        string IniFileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName) + "\\config.ini";
        char[] TrimChar = { ' ', '\t' };
        public string[] GetSects()
        {
            string[] Sects = null;

            if (File.Exists(IniFileName))
            {
                string str;
                ArrayList ls = new ArrayList();
                TextReader tr = File.OpenText(IniFileName);
                while ((str = tr.ReadLine()) != null)
                {
                    str = str.Trim();
                    if ((str.StartsWith("[")) && (str.EndsWith("]")))
                        ls.Add(str);
                }
                tr.Close();
                if (ls.Count > 0)
                {
                    Sects = new string[ls.Count];
                    for (int i = 0; i < ls.Count; i++)
                    {
                        Sects[i] = ls[i].ToString();
                    }
                }
            }
            return Sects;
        }
        public int WriteString(string sect, string keystr, string valuestr)
        {
            ArrayList ls = new ArrayList();
            bool SectOK = false;
            bool SetOK = false;
            if (File.Exists(IniFileName))
            {
                int pos1;
                string substr;
                string str;
                TextReader tr = File.OpenText(IniFileName);
                while ((str = tr.ReadLine()) != null)
                {
                    ls.Add(str);
                }
                tr.Close();
                //开始寻找关键字，如果找不到，则在这段的最后一行插入，然后再整体的保存一下INI文件。
                for (int i = 0; i < ls.Count; i++)
                {
                    str = ls[i].ToString();
                    if (str.StartsWith("[") && SectOK) //先判断是否到下一段中了,如果本来就是最后一段，那就有可能永远也不会发生了。
                    {
                        SetOK = true; //如果在这一段中没有找到，并且已经要进入下一段了，就直接在这一段末添加了。
                        ls.Insert(i, keystr.Trim() + "=" + valuestr);
                        break;//如果到下一段了，则直接退出就好。
                    }
                    if (SectOK)
                    {
                        pos1 = str.IndexOf("=");
                        if (pos1 > 1)
                        {
                            substr = str.Substring(0, pos1);
                            substr.Trim(TrimChar);
                            //如果在这一段中找到KEY了，直接修改就好了。
                            if (substr.Equals(keystr, StringComparison.OrdinalIgnoreCase) && SectOK) //是在此段中，并且KEYSTR前段也能匹配上。
                            {
                                SetOK = true;
                                ls[i] = keystr.Trim() + "=" + valuestr;
                                break;
                            }
                        }
                    }
                    if (str.StartsWith("[" + sect + "]")) //判断是否到需要的段中了。
                        SectOK = true;
                }
                if (SetOK == false)
                {
                    SetOK = true;
                    if (!SectOK) //如果没有找到段，则需要再添加段。
                    {
                        ls.Add("[" + sect + "]");
                    }
                    ls.Add(keystr.Trim() + "=" + valuestr);
                }
            } //如果文件不存在，则需要建立文件。
            else
            {
                ls.Clear();
                ls.Add("##勿删，程序配置文件。文件创建：" + DateTime.Now.ToString() + "##");
                ls.Add("[" + sect + "]");
                ls.Add(keystr.Trim() + "=" + valuestr);
            }
            if (File.Exists(IniFileName)) //删除源文件。
            {
                File.Delete(IniFileName);
            }
            TextWriter tw = File.CreateText(IniFileName);
            //string[] strList = new string[ls.Count];
            for (int i = 0; i < ls.Count; i++)
            {
                //strList[i] = ls[i].ToString();
                tw.WriteLine(ls[i].ToString());
            }
            tw.Flush();
            tw.Close();
            //File.WriteAllLines(IniFileName, strList);
            return 0;
        }
        public string ReadString(string sect, string keystr, string defaultstr)
        {
            string retstr = defaultstr;
            if (File.Exists(IniFileName))
            {
                bool SectOK = false;
                int pos1;
                string substr;
                string str;
                ArrayList ls = new ArrayList();
                TextReader tr = File.OpenText(IniFileName);
                while ((str = tr.ReadLine()) != null)
                {
                    str = str.Trim();
                    if (str.StartsWith("[") && SectOK) //先判断是否到下一段中了。
                    {
                        break;//如果到下一段了，则直接退出就好。
                    }
                    if (SectOK)
                    {
                        pos1 = str.IndexOf("=");
                        if (pos1 > 1)
                        {
                            substr = str.Substring(0, pos1);
                            substr.Trim(TrimChar);
                            if (substr.Equals(keystr, StringComparison.OrdinalIgnoreCase)) //是在此段中，并且KEYSTR前段也能匹配上。
                            {
                                retstr = str.Substring(pos1 + 1).Trim(TrimChar);
                                break;
                            }
                        }
                    }
                    if (str.StartsWith("[" + sect + "]")) //判断是否到需要的段中了。
                        SectOK = true;
                }
                tr.Close();
            }
            return retstr;
        }
        //读整数 
        public int ReadInteger(string Section, string Ident, int Default)
        {
            string intStr = ReadString(Section, Ident, Convert.ToString(Default));
            try
            {
                return Convert.ToInt32(intStr);
            }
            catch
            {
                return Default;
            }
        }

        //写整数 
        public void WriteInteger(string Section, string Ident, int Value)
        {
            WriteString(Section, Ident, Value.ToString());
        }

        //读布尔 
        public bool ReadBool(string Section, string Ident, bool Default)
        {
            try
            {
                return Convert.ToBoolean(ReadString(Section, Ident, Convert.ToString(Default)));
            }
            catch
            {
                return Default;
            }
        }
        //写Bool 
        public void WriteBool(string Section, string Ident, bool Value)
        {
            WriteString(Section, Ident, Convert.ToString(Value));
        }

        /////////////////////////////////////////////////////////////////////////
        //使用此INI文件的特例（自己使用）
        public string GetParam(string KeyStr, string Default)
        {
            string str;
            str = this.ReadString("Params", KeyStr, "???");
            if (str == "???")
            {
                this.WriteString("Params", KeyStr, Default);
                str = Default;
            }
            return str;
        }
        public void UpdateParam(string KeyStr, string ValueStr)
        {
            this.WriteString("Params", KeyStr, ValueStr);
        }

    }
}

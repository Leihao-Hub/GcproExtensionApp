﻿using GcproExtensionLibrary.Gcpro;
using System;
using System.Text;


namespace GcproExtensionLibrary
{

    public static class LibGlobalSource
    {
        #region Public const declaration
        public const string TAB = "\t";
        public const string NOCHILD = "0";
        public const string DEFAULT_GCPRO_WORK_TEMP_PATH = @"C:\temp";
        public const string MOTOR_FILE_NAME = @"\Motor.Txt";
        public const string SELECT_A_FOLDER = "选择一个文件夹";
        public const string FILE_SAVE_AS = "文件另存为";
        public const string OLEDB_PROVIDER_MDB = "Provider=Microsoft.Jet.OLEDB.4.0;";
        public const string OLEDB_PROVIDER_ACCDB = "Provider=Microsoft.ACE.OLEDB.12.0;";
        public const string EMPTY_TABLENAME_OR_FIELDNAME = "查询表名称和字段名称不能为空";
        public const string EX_FILE_NOT_FOUND = "文件未找到，请确保文件路径正确并且文件存在。";
        public const string EX_READING_FILE = "读取文件时发生错误。";
        public const string EX_IO_ERROR = "发生I/O错误";
        public const string EX_UNKNOW = "未知错误";
        public const string EX_UNAUTHORIZED_ACCESS = "没有权限访问文件。请检查文件权限。";
        public const string EX_SPECIFIED_COLUMN = "未指定读取列。";
        public const int NO_OWNER = 1;
        #endregion
        public static string[] SplitStringWithRule(string source, string rule)
        {
            //异常抛出做在调用者那边更好
            //if (string.IsNullOrEmpty(source))
            //{
            //    throw new ArgumentException("源字符串不能为空", nameof(source));
            //}

            //if (string.IsNullOrEmpty(rule))
            //{
            //    throw new ArgumentException("规则字符串不能为空", nameof(rule));
            //}
            // 使用 rule 分割 source 字符串，并移除空返回项
            string[] result = source.Split(new string[] { rule }, StringSplitOptions.RemoveEmptyEntries);
            return result;
        }

        public static RuleSubPos RuleSubPos(string source, string rule)
        {
            bool startsWithRule = source.StartsWith(rule);
            bool endsWithRule = source.EndsWith(rule);
            RuleSubPos ruleSubPos = new RuleSubPos
            {
                StartPos = startsWithRule,
                EndPos = endsWithRule,
                MidPos = !startsWithRule && !endsWithRule,
                PosInString = startsWithRule ? 0 : source.IndexOf(rule),
                Len = rule.Length
            };
            return ruleSubPos;
        }
        public static string GenerateObjectName(string[] source, RuleSubPos ruleSubPos, string rule)
        {
            string result = string.Empty;
            if (ruleSubPos.StartPos)
            { result = rule + source[0]; }
            else if (ruleSubPos.EndPos)
            { result = source[0] + rule; }
            else if (ruleSubPos.PosInString > 0)
            { result = source[0] + rule + source[1]; }
            return result;
        }
    }
    public interface IGcpro
    {

        void CreateObject(Encoding encoding);

    }
}

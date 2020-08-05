using System;
using System.Collections.Generic;
using System.Text;

namespace Incorrect.Core.Common.Helper
{
    public class FileHelper:IDisposable
    {
        private bool _alreadyDispose = false;

        #region 构造函数
        public FileHelper()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        ~FileHelper()
        {
            Dispose();
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (_alreadyDispose) return;
            _alreadyDispose = true;
        }
        #endregion
        #region Disposable
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
        #region 取得文件后缀名
        /// <summary>
        /// 取得文件后缀名称
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string GetPostfixStr(string filename)
        {
            var start = filename.LastIndexOf('.');
            var length = filename.Length;
            string postFixStr = filename.Substring(start,length-start);
            return postFixStr;
        }
            #endregion
        }
}

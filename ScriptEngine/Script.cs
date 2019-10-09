using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSScriptControl;

namespace ScriptEngine
{
    public class Script
    {
        private ScriptControl msc;
        private string _codeBody;
        /// <summary>   
        ///构造函数   
        /// </summary>   
        public Script(string codeBody) : this(ScriptLanguage.JScript, codeBody)
        {
        }
        /// <summary>   
        /// 构造函数   
        /// </summary>   
        /// <param name="language">脚本类型</param>   
        public Script(ScriptLanguage language, string codeBody)
        {
            this.msc = new ScriptControl();
            this.msc.UseSafeSubset = true;
            this.msc.Language = language.ToString();
            _codeBody = codeBody;
        }

        /// <summary>   
        /// 运行Eval方法   
        /// 可以执行方法，对象
        /// </summary>   
        /// <param name="expression">表达式</param>   
        /// <param name="codeBody">函数体</param>   
        /// <returns>返回值object</returns>   
        public object Eval(string expression)
        {
            msc.AddCode(_codeBody);
            return msc.Eval(expression);
        }
        /// <summary>   
        /// 运行Eval方法   
        /// </summary>     
        /// <param name="expression">js表达式,</param>   
        /// <param name="language">脚本语言</param>  
        /// <returns>返回值object</returns>   
        public object Eval(string expression, ScriptLanguage language)
        {
            msc.AddCode(_codeBody);
            if (this.msc.Language != language.ToString())
                this.msc.Language = language.ToString();
            return Eval(expression);
        }
        /// <summary>   
        /// 运行Run方法   
        /// </summary>   
        /// <param name="mainFunctionName">入口函数名称</param>   
        /// <param name="parameters">参数</param>   
        /// <param name="codeBody">函数体</param>   
        /// <returns>返回值object</returns>   
        public object Run(string mainFunctionName, params object[] parameters)
        {
            this.msc.AddCode(_codeBody);
            return msc.Run(mainFunctionName, ref parameters);
        }
    }
}

# ScriptEngine
C# 后台调用前台js函数方法，MSScriptControl 的封装

## 执行方法
Script scriptEngine = new Script(demoJS);  
var d = scriptEngine.Eval("say(2)");//执行方法  
var d2_1 = scriptEngine.Eval("jsonV");//调用对象  
var d2 = scriptEngine.Run("jisuan", 1, 2);//执行多个参数  

##注意事项
1、平台要求x86


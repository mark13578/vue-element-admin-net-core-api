using System;
using System.IO;
using JMWebAPI.Plugin.EasyExcel;
using NPOI.Mapper;

namespace JMWebAPI.Common.Util
{
    /// <summary>
    /// Excel 工具类
    /// </summary>
    public static class ExcelUtils
    {
        /// <summary>
        /// 导入 Excel 数据
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="inputStream">Excel 文件输入流</param>
        /// <param name="listener">处理监听器</param>
        /// <returns>处理结果消息</returns>
        public static string ImportExcel<T>(Stream inputStream, MyAnalysisEventListener<T> listener)
        {
            try
            {
                var mapper = new Mapper(inputStream);
                var items = mapper.Take<T>().ToList();

                foreach (var item in items)
                {
                    listener.Invoke(item.Value);
                }
            }
            catch (Exception ex)
            {
                return $"导入 Excel 发生错误: {ex.Message}";
            }

            return listener.GetMsg();
        }
    }
}

namespace Youlai.System.Plugin.EasyExcel
{
    public class MyAnalysisEventListener<T>
    {
        private string _msg;

        public MyAnalysisEventListener()
        {
            _msg = "";
        }

        public void Invoke(T item)
        {
            // 自定义处理逻辑
        }

        public string GetMsg()
        {
            return _msg;
        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;


    public class ResultFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            string file = "Result_Filter.txt";

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLineAsync("apply Result_Filter");
            }
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            
        }
    }


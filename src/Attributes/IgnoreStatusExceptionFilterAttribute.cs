using Newtonsoft.Json;
using WebApiClientCore.Attributes;
using WebApiClientCore.Exceptions;
using WebApiClientCore;

namespace FeishuNetSdk.Attributes;
public class IgnoreStatusExceptionFilterAttribute : ApiFilterAttribute
{
    public override System.Threading.Tasks.Task OnRequestAsync(ApiRequestContext context)
    {
        return System.Threading.Tasks.Task.CompletedTask;
    }

    public override async System.Threading.Tasks.Task OnResponseAsync(ApiResponseContext context)
    {
        if (context.Exception is ApiResponseStatusException statusException && statusException != null)
        {
            if (!context.ApiAction.Return.DataType.IsRawType && context.HttpContext.ResponseMessage != null)
            {
                string content = await context.HttpContext.ResponseMessage.Content.ReadAsStringAsync();
                JsonTextReader reader = new(new StringReader(content));

                context.Result = new JsonSerializer().Deserialize(reader, context.ApiAction.Return.DataType.Type);
            }
            else
            {
                context.Result = context.HttpContext.ResponseMessage;
            }
        }
    }
}

// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="Test_PutImV1MessageCotBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 COT事件写入 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 COT事件写入 请求体
/// <para>接口ID：7657479549125118942</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message_cot/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage_cot%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutImV1MessageCotBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "events": [
        {
            "event_type": "TOOL_CALL_START",
            "content": "{  \"toolCallId\":\"tool-run-bash-1\",  \"icon\":\"bash\",  \"title\":\"搜索一下今天的天气\",  \"toolCallName\":\"web_search\",  \"parentMessageId\":\"msg-100\"}",
            "timestamp": "1777279818"
        }
    ],
    "message_id": "om_x100b51bdee2ca964b4c213e6356a173",
    "cot_id": "7633695736571366941"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PutImV1MessageCotBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
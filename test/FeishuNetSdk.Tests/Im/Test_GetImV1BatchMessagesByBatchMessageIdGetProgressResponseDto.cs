// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询批量消息整体进度 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 查询批量消息整体进度 响应体
/// <para>接口ID：7039583318606217220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/get_progress</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fbatch_message%2fget_progress</para>
/// </summary>
[TestClass]
public class Test_GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "batch_message_send_progress": {
            "valid_user_ids_count": 204,
            "success_user_ids_count": 200,
            "read_user_ids_count": 150
        },
        "batch_message_recall_progress": {
            "recall": true,
            "recall_count": 100
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
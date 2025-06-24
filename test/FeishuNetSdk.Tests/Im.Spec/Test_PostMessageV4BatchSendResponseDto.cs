// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMessageV4BatchSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量发送消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im.Spec;

/// <summary>
/// 测试 批量发送消息 响应体
/// <para>接口ID：6907569743419555842</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/send-messages-in-batches</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucDO1EjL3gTNx4yN4UTM</para>
/// </summary>
[TestClass]
public class Test_PostMessageV4BatchSendResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "msg": "ok",
  "data": {
    "invalid_department_ids": [
      "d502aaa9514059"
    ],
    "invalid_open_ids": [
      "ou_456e168d61cec276083b357f7bd3f1491",
      "ou_f8cbdb26fb2e4eda075e003381a102a41"
    ],
    "invalid_user_ids": [
      "7cdcc7c22"
    ],
    "invalid_union_ids": [
      "on_cad4860e7af114fb4ff6c5d496d1dd76",
      "on_gdcq860e7af114fb4ff6c5d496dabcet"
    ],
    "message_id": "bm-d4be107c616aed9c1da8ed8068570a9f"
  }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.Spec.PostMessageV4BatchSendResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
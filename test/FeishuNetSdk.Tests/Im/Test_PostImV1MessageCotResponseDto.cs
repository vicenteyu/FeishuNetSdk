// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="Test_PostImV1MessageCotResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建COT 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 创建COT 响应体
/// <para>接口ID：7657479549125069790</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message_cot/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage_cot%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessageCotResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "cot_id": "7655611992547478740",
        "message_id": "om_x100b6cd766729880c3a7d8560446871"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1MessageCotResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
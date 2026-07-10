// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="Test_PostImV1MessageCotBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建COT 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 创建COT 请求体
/// <para>接口ID：7657479549125069790</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message_cot/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage_cot%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessageCotBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "receive_id": "oc_1b325300f109e05a435e4bde1f7b2ab0",
    "origin_message_id": "om_x100b508415d77930ee08f62ce1c1c39"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1MessageCotBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostContactV2UserBatchAddResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量新增用户 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact.Spec;

/// <summary>
/// 测试 批量新增用户 响应体
/// <para>接口ID：6907569743420997634</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/batch-add-users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDOwUjLygDM14iM4ATN</para>
/// </summary>
[TestClass]
public class Test_PostContactV2UserBatchAddResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "task_id": "123456784b68a7c89abcdef092dc09ea"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.Spec.PostContactV2UserBatchAddResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
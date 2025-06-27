// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDocV2MetaByDocTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取旧版文档元信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取旧版文档元信息 响应体
/// <para>接口ID：6907569524100448257</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/document/obtain-document-meta</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuczN3UjL3czN14yN3cTN</para>
/// </summary>
[TestClass]
public class Test_GetDocV2MetaByDocTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "create_date": "20240808",
        "create_time": 1723088043,
        "creator": "ou_f700228a5386f25bc0e61135066abcef",
        "create_user_name": "ZhangSan",
        "delete_flag": 0,
        "edit_time": 1723088073,
        "edit_user_name": "ZhangSan",
        "is_external": false,
        "is_pined": false,
        "is_stared": false,
        "is_upgraded": true,
        "obj_type": "doc",
        "owner": "ou_f700228a5386f25bc0e61135066abcef",
        "owner_user_name": "ZhangSan",
        "server_time": 1723089073,
        "tenant_id": "42",
        "title": "项目管理",
        "type": 2,
        "upgraded_token": "AcJ3d2QM1onnE4xjcZAcP7abcef",
        "url": "https://example.feishu.cn/docs/doccnilYPZU5b34ow4ca7aabcef"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetDocV2MetaByDocTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
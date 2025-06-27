// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMdmV1UserAuthDataRelationsBindBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 用户数据维度绑定 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mdm;

/// <summary>
/// 测试 用户数据维度绑定 请求体
/// <para>接口ID：7120547953915510787</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mdm-v1/user_auth_data_relation/bind</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v1%2fuser_auth_data_relation%2fbind</para>
/// </summary>
[TestClass]
public class Test_PostMdmV1UserAuthDataRelationsBindBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "root_dimension_type": "gongsi",
    "sub_dimension_types": [
        "code_dimension"
    ],
    "authorized_user_ids": [
        "ou_7dab8a3d3cdcc9da365777c7ad535d62"
    ],
    "uams_app_id": "uams-tenant-test"
}
""";
        var result = Deserialize<FeishuNetSdk.Mdm.PostMdmV1UserAuthDataRelationsBindBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
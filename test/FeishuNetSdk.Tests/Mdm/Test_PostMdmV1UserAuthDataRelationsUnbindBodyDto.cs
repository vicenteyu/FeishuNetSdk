// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMdmV1UserAuthDataRelationsUnbindBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 用户数据维度解绑 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mdm;

/// <summary>
/// 测试 用户数据维度解绑 请求体
/// <para>接口ID：7120547953915527171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mdm-v1/user_auth_data_relation/unbind</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v1%2fuser_auth_data_relation%2funbind</para>
/// </summary>
[TestClass]
public class Test_PostMdmV1UserAuthDataRelationsUnbindBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "root_dimension_type": "gongsi",
    "sub_dimension_types": [
        "zijie"
    ],
    "authorized_user_ids": [
        "on_21f2db9bdbafadeb16cd77b76060d41d"
    ],
    "uams_app_id": "uams-tenant-test"
}
""";
        var result = Deserialize<FeishuNetSdk.Mdm.PostMdmV1UserAuthDataRelationsUnbindBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
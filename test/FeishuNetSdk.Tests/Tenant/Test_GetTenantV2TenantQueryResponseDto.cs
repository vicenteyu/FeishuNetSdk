// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTenantV2TenantQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取企业信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Tenant;

/// <summary>
/// 测试 获取企业信息 响应体
/// <para>接口ID：6954228485356568579</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/tenant-v2/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftenant-v2%2ftenant%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetTenantV2TenantQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tenant": {
            "name": "企业名称",
            "display_id": "F123456789",
            "tenant_tag": 0,
            "tenant_key": "abcdefghi",
            "avatar": {
                "avatar_origin": "https://foo.icon.com/xxxx",
                "avatar_72": "https://foo.icon.com/xxxx",
                "avatar_240": "https://foo.icon.com/xxxx",
                "avatar_640": "https://foo.icon.com/xxxx"
            },
            "domain": "example.feishu.cn"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Tenant.GetTenantV2TenantQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
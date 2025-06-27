// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTenantV2TenantAssignInfoListQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取企业席位信息接口 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Tenant;

/// <summary>
/// 测试 获取企业席位信息接口 响应体
/// <para>接口ID：7204729599813222401</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/tenant-v2/tenant-product_assign_info/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftenant-v2%2ftenant-product_assign_info%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetTenantV2TenantAssignInfoListQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "assign_info_list": [
            {
                "subscription_id": "7079609167680782300",
                "license_plan_key": "suite_enterprise_e5",
                "product_name": "旗舰版 E5",
                "i18n_name": {
                    "zh_cn": "zh_cn_name",
                    "ja_jp": "ja_jp_name",
                    "en_us": "en_name"
                },
                "total_seats": "500",
                "assigned_seats": "20",
                "start_time": "1674981000",
                "end_time": "1674991000"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Tenant.GetTenantV2TenantAssignInfoListQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
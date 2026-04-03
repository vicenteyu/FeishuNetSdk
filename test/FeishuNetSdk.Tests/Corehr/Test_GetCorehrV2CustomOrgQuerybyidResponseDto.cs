// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_GetCorehrV2CustomOrgQuerybyidResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询单个人员自定义组织变更记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询单个人员自定义组织变更记录 响应体
/// <para>接口ID：7425878850969419780</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/employee-custom_org/querybyid</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee-custom_org%2fquerybyid</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2CustomOrgQuerybyidResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "custom_org": [
            {
                "custom_org_list": [
                    {
                        "custom_org_name": {
                            "zh_cn": "王冰",
                            "en_us": "Bob"
                        },
                        "custom_org_id": "7293641346149138452",
                        "rate": "42.98"
                    }
                ],
                "effective_time": "2024-06-13 00:00:00",
                "start_reason": "自动打标",
                "job_data_custom_org_id": "7260357352426782739",
                "version_id": "7260357352426782749",
                "object_api_name": "custom_org_03",
                "user_id": "7352797725202581036"
            }
        ],
        "user_id": "006"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2CustomOrgQuerybyidResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
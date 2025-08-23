// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_GetCompensationV1SocialInsurancesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取险种配置列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 获取险种配置列表 响应体
/// <para>接口ID：7420038908975415298</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_insurance/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_insurance%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCompensationV1SocialInsurancesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "7207415762276992556",
                "name": {
                    "zh_cn": "生育保险",
                    "en_us": "maternity insurance"
                },
                "insurance_type": "social_insurance",
                "active": true,
                "is_system": true
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.GetCompensationV1SocialInsurancesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
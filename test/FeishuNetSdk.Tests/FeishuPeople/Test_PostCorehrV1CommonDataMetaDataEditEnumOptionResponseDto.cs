// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1CommonDataMetaDataEditEnumOptionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改字段枚举值选项 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 修改字段枚举值选项 响应体
/// <para>接口ID：7385867895124328452</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/custom_field/edit_enum_option</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-meta_data%2fedit_enum_option</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1CommonDataMetaDataEditEnumOptionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "enum_field_api_name": "final_assessment_grade",
        "enum_field_options": [
            {
                "option_api_name": "grade_e",
                "active": true,
                "name": {
                    "zh_cn": "cn",
                    "en_us": "en"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1CommonDataMetaDataEditEnumOptionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 增加字段枚举值选项 响应体
/// <para>接口ID：7385867895124344836</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/custom_field/add_enum_option</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-meta_data%2fadd_enum_option</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1CommonDataMetaDataAddEnumOptionResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1CommonDataMetaDataAddEnumOptionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建部门 请求体
/// <para>接口ID：7072646559953797122</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1DepartmentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "sub_type": {
        "enum_name": "type_1"
    },
    "manager": "6893013238632416776",
    "is_confidential": true,
    "hiberarchy_common": {
        "parent_id": "4719168654814483759",
        "name": [
            {
                "lang": "zh-CN",
                "value": "研发部"
            }
        ],
        "active": true,
        "code": "12456",
        "description": [
            {
                "lang": "zh-CN",
                "value": "张三"
            }
        ]
    },
    "effective_time": "2020-05-01 00:00:00",
    "custom_fields": [
        {
            "field_name": "name",
            "value": "\"Sandy\""
        }
    ],
    "cost_center_id": "7142384817131652652",
    "staffing_model": {
        "enum_name": "position"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1DepartmentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
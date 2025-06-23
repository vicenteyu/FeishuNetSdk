namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建假期发放记录 请求体
/// <para>接口ID：7127187941650612227</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave_granting_record%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1LeaveGrantingRecordsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "leave_type_id": "7111688079785723436",
    "employment_id": "6982509313466189342",
    "granting_quantity": "0.5",
    "granting_unit": 1,
    "effective_date": "2022-01-01",
    "expiration_date": "2022-01-01",
    "section_type": 1,
    "reason": [
        {
            "lang": "zh_CN",
            "value": "张三"
        }
    ],
    "external_id": "111"
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1LeaveGrantingRecordsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
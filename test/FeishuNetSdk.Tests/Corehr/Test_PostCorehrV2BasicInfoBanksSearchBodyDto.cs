namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询银行信息 请求体
/// <para>接口ID：7301516605753196547</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-bank/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-bank%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoBanksSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "bank_id_list": [
        "MDBH00000080"
    ],
    "bank_name_list": [
        "招商银行"
    ],
    "status_list": [
        1
    ],
    "update_start_time": "2020-01-01 00:00:00",
    "update_end_time": "2024-01-01 00:00:00"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoBanksSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
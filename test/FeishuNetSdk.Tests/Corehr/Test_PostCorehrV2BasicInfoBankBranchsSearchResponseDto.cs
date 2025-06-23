namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询支行信息 响应体
/// <para>接口ID：7301516605753212931</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-bank/search-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-bank_branch%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoBankBranchsSearchResponseDto : TestBase
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
                "bank_branch_id": "MDBK00061194",
                "bank_branch_name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "bank_id": "MDBH00000080",
                "code": "308100005019",
                "swift_code": "CMBCCNBS201",
                "status": 1,
                "bank_branch_code": "B04",
                "register_place": "北京市朝阳区",
                "bank_address": "北京市朝阳区",
                "create_time": "2020-01-01 00:00:00",
                "update_time": "2024-01-01 00:00:00"
            }
        ],
        "page_token": "MDBK00000120",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoBankBranchsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
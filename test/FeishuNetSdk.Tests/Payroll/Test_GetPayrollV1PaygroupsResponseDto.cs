namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 获取薪资组基本信息 响应体
/// <para>接口ID：7405412186246627329</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/paygroup/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpaygroup%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPayrollV1PaygroupsResponseDto : TestBase
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
                "pay_group_id": "6823630319749580301",
                "name": {
                    "zh_cn": "CHN-审核",
                    "en_us": "english name"
                },
                "code": "PAY_GROUP-3-8",
                "status": 1
            }
        ],
        "page_token": "6862995757234914824",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.GetPayrollV1PaygroupsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
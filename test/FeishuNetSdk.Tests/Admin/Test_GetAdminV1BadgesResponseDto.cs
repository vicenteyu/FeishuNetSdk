namespace FeishuNetSdk.Tests.Admin;

/// <summary>
/// 测试 获取勋章列表 响应体
/// <para>接口ID：7104154222309048323</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAdminV1BadgesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "badges": [
            {
                "id": "m_MzfKDM",
                "name": "激励勋章",
                "explanation": "这枚勋章为了激励员工颁发。",
                "detail_image": "75a1949f-d9df-4b46-bc88-dacc51e88f3j",
                "show_image": "03daa74a-159f-49e9-963e-b6c4d76103fj",
                "i18n_name": {
                    "zh_cn": "激励勋章",
                    "en_us": "Incentive Medal",
                    "ja_jp": "奨励メダル"
                },
                "i18n_explanation": {
                    "zh_cn": "激励勋章",
                    "en_us": "Incentive Medal",
                    "ja_jp": "奨励メダル"
                }
            }
        ],
        "page_token": "h121921",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Admin.GetAdminV1BadgesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
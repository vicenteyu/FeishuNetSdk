// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAdminV1BadgesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建勋章 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Admin;

/// <summary>
/// 测试 创建勋章 响应体
/// <para>接口ID：7104154222309146627</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAdminV1BadgesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "badge": {
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
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Admin.PostAdminV1BadgesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
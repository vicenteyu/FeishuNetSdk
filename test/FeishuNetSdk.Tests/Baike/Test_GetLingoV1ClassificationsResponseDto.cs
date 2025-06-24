// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetLingoV1ClassificationsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取词典分类 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 获取词典分类 响应体
/// <para>接口ID：7249689905697161244</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/classification/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fclassification%2flist</para>
/// </summary>
[TestClass]
public class Test_GetLingoV1ClassificationsResponseDto : TestBase
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
                "id": "7049606926****37761",
                "name": "行业术语",
                "father_id": "704960692***837777",
                "i18n_names": [
                    {
                        "language": 1,
                        "name": "词典分类"
                    }
                ]
            }
        ],
        "page_token": "408ecac018b2e3518db37275e812****bb8ad3e755fc886f322ac6c430ba",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.GetLingoV1ClassificationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
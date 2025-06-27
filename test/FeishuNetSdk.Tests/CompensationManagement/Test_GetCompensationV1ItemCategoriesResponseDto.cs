// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCompensationV1ItemCategoriesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取薪资项分类信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量获取薪资项分类信息 响应体
/// <para>接口ID：7314129756769763332</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/compensation-component-and-metric/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fitem_category%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCompensationV1ItemCategoriesResponseDto : TestBase
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
                "id": "4532312334",
                "name": "基本薪资类",
                "i18n_names": [
                    {
                        "locale": "zh_cn",
                        "value": "中文名称"
                    }
                ]
            }
        ],
        "page_token": "2314123434",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.GetCompensationV1ItemCategoriesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
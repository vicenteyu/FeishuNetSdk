// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出视图 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出视图 响应体
/// <para>接口ID：6978670625209597954</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": false,
        "items": [{
                "view_id": "vewqtI3f2u",
                "view_name": "公共表格视图",
                "view_public_level": "Public",
                "view_type": "grid"
            },
            {
                "view_id": "vew5Ys1Y1B",
                "view_name": "个人表格视图",
                "view_private_owner_id": "ou_fe4e2a0c10f41fb85620eb4b71d12082",
                "view_public_level": "Private",
                "view_type": "grid"
            }
        ],
        "page_token": "vew5Ys1Y1B",
        "total": 2
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
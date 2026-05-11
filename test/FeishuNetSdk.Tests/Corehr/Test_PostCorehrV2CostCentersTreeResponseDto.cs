// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="Test_PostCorehrV2CostCentersTreeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定生效日期的成本中心架构树 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询指定生效日期的成本中心架构树 响应体
/// <para>接口ID：7637139455451139033</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/tree</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2ftree</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostCentersTreeResponseDto : TestBase
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
                "id": "7140964208476371111",
                "level": 1,
                "children": [
                    "6862995757234914824"
                ]
            }
        ],
        "page_token": "7140964208476371111",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CostCentersTreeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
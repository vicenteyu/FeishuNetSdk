// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-14
//
// Last Modified By : yxr
// Last Modified On : 2026-03-14
// ************************************************************************
// <copyright file="Test_PostApprovalV4DistrictsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索地理库信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 搜索地理库信息 请求体
/// <para>接口ID：7579169568158502093</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/district/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fdistrict%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4DistrictsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "district_ids": [
        "1816670"
    ],
    "keyword": "北京"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4DistrictsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
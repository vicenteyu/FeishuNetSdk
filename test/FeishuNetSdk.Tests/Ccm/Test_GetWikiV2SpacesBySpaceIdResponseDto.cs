// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetWikiV2SpacesBySpaceIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取知识空间信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取知识空间信息 响应体
/// <para>接口ID：7023947709203857412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2fget</para>
/// </summary>
[TestClass]
public class Test_GetWikiV2SpacesBySpaceIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "space": {
            "name": "知识空间",
            "description": "知识空间描述",
            "space_id": "1565676577122621"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetWikiV2SpacesBySpaceIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
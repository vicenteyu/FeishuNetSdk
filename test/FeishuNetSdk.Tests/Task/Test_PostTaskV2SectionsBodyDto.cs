// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2SectionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建自定义分组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建自定义分组 请求体
/// <para>接口ID：7259330038033809436</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/section/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2SectionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "已经审核过的任务",
    "resource_type": "tasklist",
    "resource_id": "cc371766-6584-cf50-a222-c22cd9055004",
    "insert_before": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2",
    "insert_after": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2SectionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
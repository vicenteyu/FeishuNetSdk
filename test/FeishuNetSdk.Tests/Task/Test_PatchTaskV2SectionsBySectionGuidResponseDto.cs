// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchTaskV2SectionsBySectionGuidResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新自定义分组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新自定义分组 响应体
/// <para>接口ID：7259330038033842204</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/section/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2SectionsBySectionGuidResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "section": {
            "guid": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2",
            "name": "已经评审过的任务",
            "resource_type": "tasklist",
            "is_default": true,
            "creator": {
                "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                "type": "user",
                "role": "editor"
            },
            "tasklist": {
                "guid": "cc371766-6584-cf50-a222-c22cd9055004",
                "name": "活动分工任务列表"
            },
            "created_at": "1675742789470",
            "updated_at": "1675742789470"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PatchTaskV2SectionsBySectionGuidResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
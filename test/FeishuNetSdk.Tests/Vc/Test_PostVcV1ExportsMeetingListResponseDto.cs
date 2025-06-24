// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostVcV1ExportsMeetingListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 导出会议明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 导出会议明细 响应体
/// <para>接口ID：7124235806021238785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/meeting_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fmeeting_list</para>
/// </summary>
[TestClass]
public class Test_PostVcV1ExportsMeetingListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "task_id": "7111325589855797267"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1ExportsMeetingListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
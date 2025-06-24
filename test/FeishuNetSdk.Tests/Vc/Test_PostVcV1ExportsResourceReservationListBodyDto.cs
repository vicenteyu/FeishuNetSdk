// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostVcV1ExportsResourceReservationListBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 导出会议室预定数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 导出会议室预定数据 请求体
/// <para>接口ID：7124195547444510748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/resource_reservation_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fresource_reservation_list</para>
/// </summary>
[TestClass]
public class Test_PostVcV1ExportsResourceReservationListBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "room_level_id": "omb_57c9cc7d9a81e27e54c8fabfd02759e7",
    "need_topic": true,
    "start_time": "1655276858",
    "end_time": "1655276858",
    "room_ids": [
        "omm_eada1d61a550955240c28757e7dec3af"
    ],
    "is_exclude": false
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1ExportsResourceReservationListBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
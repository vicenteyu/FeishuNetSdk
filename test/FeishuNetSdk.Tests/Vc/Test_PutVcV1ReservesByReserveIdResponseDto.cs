// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutVcV1ReservesByReserveIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新预约 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 更新预约 响应体
/// <para>接口ID：6921909217674854427</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutVcV1ReservesByReserveIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "reserve": {
            "id": "6911188411934973028",
            "meeting_no": "112000358",
            "password": "971024",
            "url": "https://vc.feishu.cn/j/337736498",
            "live_link": "https://meetings.feishu.cn/s/1gub381l4gglv",
            "end_time": "1608883322",
            "expire_status": 0
        },
        "reserve_correction_check_info": {
            "invalid_host_id_list": [
                "ou_3ec3f6a28a0d08c45d895276e8e5e19b"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PutVcV1ReservesByReserveIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
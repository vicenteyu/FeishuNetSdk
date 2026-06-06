// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_GetOkrV2CyclesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取用户 OKR 周期列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 获取用户 OKR 周期列表 响应体
/// <para>接口ID：7644863390543989724</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-cycle/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-cycle%2flist</para>
/// </summary>
[TestClass]
public class Test_GetOkrV2CyclesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "1",
        "items": [
            {
                "id": "7342342398472398471",
                "create_time": "1760604634563",
                "update_time": "1760604634563",
                "tenant_cycle_id": "7342342398472398472",
                "owner": {
                    "owner_type": "user",
                    "user_id": "ou_3bbe8a09c20e89cce9bff989ed840674"
                },
                "start_time": "1760604634563",
                "end_time": "1760604634563",
                "cycle_status": 1,
                "score": 0.5
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV2CyclesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}
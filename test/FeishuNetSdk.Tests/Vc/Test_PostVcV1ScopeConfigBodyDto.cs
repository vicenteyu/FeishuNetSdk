namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 设置会议室配置 请求体
/// <para>接口ID：7160517357591920643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fscope_config%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostVcV1ScopeConfigBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "scope_type": 1,
    "scope_id": "omm_608d34d82d531b27fa993902d350a307",
    "scope_config": {
        "room_background": "https://lf1-ttcdn-tos.pstatp.com/obj/xxx",
        "display_background": "https://lf1-ttcdn-tos.pstatp.com/obj/xxx",
        "digital_signage": {
            "if_cover_child_scope": true,
            "enable": true,
            "mute": true,
            "start_display": 3,
            "stop_display": 3,
            "materials": [
                {
                    "id": "7847784676276",
                    "name": "name",
                    "material_type": 0,
                    "url": "url",
                    "duration": 15,
                    "cover": "url",
                    "md5": "md5",
                    "vid": "vid",
                    "size": "100"
                }
            ]
        },
        "room_box_digital_signage": {
            "if_cover_child_scope": true,
            "enable": true,
            "mute": true,
            "start_display": 3,
            "stop_display": 3,
            "materials": [
                {
                    "id": "7847784676276",
                    "name": "name",
                    "material_type": 0,
                    "url": "url",
                    "duration": 15,
                    "cover": "url",
                    "md5": "md5",
                    "vid": "v039b2g10000ca89uj3c77u5pfdkfvpg",
                    "size": "100"
                }
            ]
        },
        "room_status": {
            "status": true,
            "schedule_status": true,
            "disable_start_time": "1652356050",
            "disable_end_time": "1652442450",
            "disable_reason": "测试占用",
            "contact_ids": [
                "ou_3ec3f6a28a0d08c45d895276e8e5e19b"
            ],
            "disable_notice": true,
            "resume_notice": true
        }
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1ScopeConfigBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
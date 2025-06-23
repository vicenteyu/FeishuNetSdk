namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新职位设置 请求体
/// <para>接口ID：7012986483075563521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/update_config</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fupdate_config</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobsByJobIdUpdateConfigBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "offer_apply_schema_id": "6960663240925956573",
    "offer_process_conf": "6960663240925956572",
    "recommended_evaluator_id_list": [
        "6966533137982392320"
    ],
    "update_option_list": [
        6
    ],
    "assessment_template_biz_id": "6960663240925956571",
    "interview_round_conf_list": [
        {
            "interviewer_id_list": [
                "6960663240925956571"
            ],
            "round": 1
        }
    ],
    "jr_id_list": [
        "6966533137982392320"
    ],
    "interview_registration_schema_id": "6930815272790114324",
    "onboard_registration_schema_id": "6930815272790114324",
    "interview_round_type_conf_list": [
        {
            "round_biz_id": "7012129842917837100",
            "assessment_template_biz_id": "6960663240925956632"
        }
    ],
    "related_job_id_list": [
        "6966533137982392320"
    ],
    "interview_appointment_config": {
        "enable_interview_appointment_by_interviewer": true,
        "config": {
            "interview_type": 1,
            "talent_timezone_code": "Asia/Shanghai",
            "contact_user_id": "ou_c99c5f35d542efc7ee492afe11af19ef",
            "contact_mobile": "151********",
            "contact_email": "test@email",
            "address_id": "6960663240925956576",
            "video_type": 1,
            "cc": [
                "6930815272790114324"
            ],
            "remark": "仅仅用于视频面试",
            "interview_notification_template_id": "6960663240925956573",
            "appointment_notification_template_id": "6960663240925956573",
            "cancel_interview_notification_template_id": "6960663240925956573"
        }
    },
    "portal_website_apply_form_schema_id": "6930815272790114324"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1JobsByJobIdUpdateConfigBodyDto>(json);
        Assert.IsNotNull(result);
    }
}
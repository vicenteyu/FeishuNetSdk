namespace FeishuNetSdk
{
    /// <summary>
    /// DTO扩展方法
    /// </summary>
    public static class DtoExtensions
    {
        /// <summary>
        /// 设置控件的方法
        /// </summary>
        /// <param name="Dto">创建审批实例 请求体</param>
        /// <param name="FormControls">
        /// <para>支持的控件明细参见：FeishuNetSdk.Approval.Dto 命名空间下：</para>
        /// <list type="bullet">
        /// <item>InputFormControl</item>
        /// <item>TextareaFormControl</item>
        /// <item>NumberFormControl</item>
        /// <item>AmountFormControl</item>
        /// <item>DateFormControl</item>
        /// <item>DateIntervalFormControl</item>
        /// <item>FormulaFormControl</item>
        /// <item>AttachmentFormControl</item>
        /// <item>ImageFormControl</item>
        /// <item>ContactFormControl</item>
        /// <item>ConnectFormControl</item>
        /// <item>RadioFormControl</item>
        /// <item>CheckboxFormControl</item>
        /// <item>FieldListFormControl</item>
        /// <item>DepartmentFormControl</item>
        /// <item>TelephoneFormControl</item>
        /// <item>ShiftGroupFormControl</item>
        /// </list>
        /// </param>
        public static void SetFormControls(
            this Approval.PostApprovalV4InstancesBodyDto Dto,
            object[] FormControls)
                => Dto.Form = System.Text.Json.JsonSerializer.Serialize(FormControls);

        /// <summary>
        /// 获取序列化的控件信息
        /// </summary>
        /// <param name="Dto">查看指定审批定义 响应体</param>
        /// <returns>序列化的控件数组</returns>
        public static Approval.Dtos.FromControl[]? GetFormControls(
            this Approval.GetApprovalV4ApprovalsByApprovalCodeResponseDto? Dto)
                => Dto is null ? null
                    : System.Text.Json.JsonSerializer.Deserialize<Approval.Dtos.FromControl[]>(Dto.Form);
    }
}

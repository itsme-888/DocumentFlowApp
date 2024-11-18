using System.ComponentModel.DataAnnotations;

namespace DocumentFlowApp.Common.Enums
{
    public enum RequestStatusEnum
    {
        [Display(Name = "Новый")]
        New,

        [Display(Name = "Нужны правки")]
        NeedEdit,

        [Display(Name = "Правки внесены")]
        Fixed,

        [Display(Name = "Согласован")]
        Approved,
    }
}

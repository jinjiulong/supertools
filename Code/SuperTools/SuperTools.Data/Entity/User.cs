using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperTools.Data.Entity
{
    /// <summary>
    /// 用户
    /// </summary>
    [Table("t_user")]
    public class User
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        [Key]
        [Column("id")]
        public long Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 用户编号
        /// </summary>
        [Column("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// 邮箱
        /// </summary>
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// qq
        /// </summary>
        [Column("qq")]
        public string QQ { get; set; } = string.Empty;

        [Column("password")]
        public string Password { get; set; } = string.Empty;
    }
}

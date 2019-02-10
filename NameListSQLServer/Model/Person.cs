using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameListSQLServer.Model
{
    [Table("m_persons")]
    public class Person
    {
        public Person(string personId, string personName, string mailAddress, string phoneNumber, string detail, DateTime createdDatetime, DateTime updatedDatetime)
        {
            this.personId = personId;
            this.personName = personName;
            this.mailAddress = mailAddress;
            this.phoneNumber = phoneNumber;
            this.detail = detail;
            this.createdDatetime = createdDatetime;
            this.updatedDatetime = updatedDatetime;
        }

        public Person()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]  //NotNULL
        [DisplayName("社員ID")]
        [StringLength(100)]
        public string personId { get; set; }

        [Required]  //NotNULL
        [DisplayName("社員名")]
        [StringLength(100)]
        public string personName { get; set; }

        [DisplayName("メールアドレス")]
        [EmailAddress]
        public string mailAddress { get; set; }

        [DisplayName("電話番号")]
        [StringLength(20)]
        public string phoneNumber { get; set; }
        
        [DisplayName("詳細")]
        [StringLength(200)]
        public string detail { get; set; }

        [DisplayName("作成日時")]
        public DateTime createdDatetime { get; set; }

        [DisplayName("更新日時")]
        public DateTime updatedDatetime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagement.Data;
using BookManagement.Entities;

namespace BookManagement.Repositories
{
    internal class MemberRepository
    {
        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStore.Members;
            return new GenericResponse<List<Member>>()
            {
                Success = true,
                Data = members
            };
        }
        public GenericResponse<Member> GetMemberById(int id,string email)
        {

            var membersName = DataStore.Members.FirstOrDefault(x => x.Id == id);
            var memberEmail = DataStore.Members.FirstOrDefault(x => x.Email == email);
            if (membersName == null  && memberEmail==null)
            {
                return new GenericResponse<Member>()
                {
                    Success = false,
                    Message = "Member not found"
                };
            }
            return new GenericResponse<Member>()
            {
                Success = true,
                Data = membersName
                
            };
        }
    }
}

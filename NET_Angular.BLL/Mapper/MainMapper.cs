using AutoMapper;
using NET_Angular.BLL.Models;
using NET_Angular.DAL.Entity;
using System;

namespace NET_Angular.BLL.Mapper
{
    public class MainMapper : Profile
    {
        public MainMapper()
        {
            CreateMap<CreateUpdateNoteModel, Note>()
                .ForMember(src => src.Id, opt => opt.MapFrom(z => CheckId(z.Id)));
            CreateMap<Note, GetNotesHomeModelItem>();
        }

        public static string CheckId(string noteId)
        {
            return noteId is null ? Guid.NewGuid().ToString() : noteId;
        }
    }
}

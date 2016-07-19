using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBase.Models.VesselVisit;
using AutoMapper;
using MVCBase.Models.Container;

namespace MVCBase.Infracstructure
{
    public class AutoMapperConfig
    {
        public static void Configuration()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Container, ContainerViewModel>()
                    .ForMember(des => des.equipmentNbr, or => or.MapFrom(f => f.equipmentNbr))
                    .ForMember(des => des.typeIso, or => or.MapFrom(f => f.typeIso))
                    .ForMember(des => des.gKey, or => or.MapFrom(f => f.gKey))
                    .ForMember(des => des.owner, or => or.MapFrom(f => f.owner))
                    .ForMember(des => des.safewt, or => or.MapFrom(f => f.safewt))
                    .ForMember(des => des.tareWt, or => or.MapFrom(f => f.tareWt))
                    .ForMember(des => des.typeLength, or => or.MapFrom(f => f.typeLength));

                cfg.CreateMap<ContainerViewModel, Container>()
                    .ForMember(des => des.equipmentNbr, or => or.MapFrom(f => f.equipmentNbr))
                    .ForMember(des => des.typeIso, or => or.MapFrom(f => f.typeIso))
                    .ForMember(des => des.gKey, or => or.MapFrom(f => f.gKey))
                    .ForMember(des => des.owner, or => or.MapFrom(f => f.owner))
                    .ForMember(des => des.safewt, or => or.MapFrom(f => f.safewt))
                    .ForMember(des => des.tareWt, or => or.MapFrom(f => f.tareWt))
                    .ForMember(des => des.typeLength, or => or.MapFrom(f => f.typeLength));
                    
                cfg.CreateMap<VesselVisit, VesselVisitModel>()
                    .ForMember(des => des.Id, or => or.MapFrom(f => f.id))
                    .ForMember(des => des.Ata, or => or.MapFrom(f => f.ata))
                    .ForMember(des => des.Atd, or => or.MapFrom(f => f.atd))
                    .ForMember(des => des.Eta, or => or.MapFrom(f => f.eta))
                    .ForMember(des => des.Etd, or => or.MapFrom(f => f.etd))
                    .ForMember(des => des.Id, or => or.MapFrom(f => f.id))
                    .ForMember(des => des.Line, or => or.MapFrom(f => f.line))
                    .ForMember(des => des.Phase, or => or.MapFrom(f => f.phase))
                    .ForMember(des => des.Serv, or => or.MapFrom(f => f.serv))
                    .ForMember(des => des.VesselName, or => or.MapFrom(f => f.vesselName))
                    .ForMember(des => des.Visit, or => or.MapFrom(f => f.visit));

                cfg.CreateMap<VesselVisitModel, VesselVisit>()
                   .ForMember(des => des.id, or => or.MapFrom(f => f.Id))
                    .ForMember(des => des.ata, or => or.MapFrom(f => f.Ata))
                    .ForMember(des => des.atd, or => or.MapFrom(f => f.Atd))
                    .ForMember(des => des.eta, or => or.MapFrom(f => f.Eta))
                    .ForMember(des => des.etd, or => or.MapFrom(f => f.Etd))
                    .ForMember(des => des.id, or => or.MapFrom(f => f.Id))
                    .ForMember(des => des.line, or => or.MapFrom(f => f.Line))
                    .ForMember(des => des.phase, or => or.MapFrom(f => f.Phase))
                    .ForMember(des => des.serv, or => or.MapFrom(f => f.Serv))
                    .ForMember(des => des.vesselName, or => or.MapFrom(f => f.VesselName))
                    .ForMember(des => des.visit, or => or.MapFrom(f => f.Visit));



            });
        }
    }
}
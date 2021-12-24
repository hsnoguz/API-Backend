using DAL.Model;
using Repository;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfLeftMenuDal : IEfLeftMenuDal
    {
        IRepository<LeftMenu> _repository;
        ManagerContext _context;
        public EfLeftMenuDal(IRepository<LeftMenu> repository, ManagerContext context)
        {
            _repository = repository;
            _context = context;
        }

        public void AddLeftMenu(LeftMenu leftMenu)
        {
            _repository.Insert(leftMenu);
        }

        public void DeleteLeftMenu(int Id)
        {
            LeftMenu leftmenu = _repository.GetById(Id);
            leftmenu.isActive = false;
            _repository.Update(leftmenu);
        }

        public void EditLeftMenu(LeftMenu leftMenu)
        {
            LeftMenu _leftmenu = _repository.GetById(leftMenu.Id);
            
        }

        public List<LeftMenu> GetLeftMenu(int roleId, int userId)
        {
            var menu = (from leftMenu in _context.LeftMenus
                        join claim in _context.UserLeftMenuClaims
                  on leftMenu.Id equals claim.LeftMenuId
                        where claim.OperationClaimId == roleId && leftMenu.isActive==true
                        orderby leftMenu.MenuIndex
                        select new DAL.Model.LeftMenu
                        {
                            Id = leftMenu.Id,
                            MenuId = leftMenu.MenuId,
                            OnClick = leftMenu.OnClick,
                            Src = leftMenu.Src,
                            ImageUrl = leftMenu.ImageUrl,
                            Description = leftMenu.Description,
                            MenuIndex = leftMenu.MenuIndex
                        }).ToList();/*_repository.Table.ToList(); /*new List<LeftMenu>();*/
            /*   (from users in _context.AppUsers
                join leftMenu in _context.LeftMenus
           on users.RoleId equals leftMenu.AccessRank
                where users.RoleId <= roleId && users.Id == userId
                orderby leftMenu.MenuIndex
                select new DAL.Model.LeftMenu
                {
                    Id = leftMenu.Id,
                    MenuId = leftMenu.MenuId,
                    OnClick = leftMenu.OnClick,
                    Src = leftMenu.Src,
                    Description = leftMenu.Description,
                    MenuIndex = leftMenu.MenuIndex,
                    ImageUrl = leftMenu.ImageUrl,
                    ImageUrl2 = leftMenu.ImageUrl2
                }).ToList();
            */
            return menu;
        }

        public List<LeftMenuClaimDto> GetLeftMenuFull()
        {

                var menu = (from leftMenu in _context.LeftMenus
                            join claim in _context.UserLeftMenuClaims.DefaultIfEmpty()
                      on leftMenu.Id equals claim.LeftMenuId 

                            into leftMenuClaim
                            from resultMenu in leftMenuClaim.DefaultIfEmpty()
                            where leftMenu.isActive == true
                  
                      
                         
                            select new LeftMenuClaimDto()
                            {
                                Id = leftMenu.Id,
                                MenuId = leftMenu.MenuId,
                                OnClick = leftMenu.OnClick,
                                Src = leftMenu.Src,
                                ImageUrl = leftMenu.ImageUrl,
                                Description = leftMenu.Description,
                                MenuIndex = leftMenu.MenuIndex,
                                ClaimId = resultMenu.OperationClaim!=null? resultMenu.OperationClaim.Id:0,
                                ClaimName= resultMenu.OperationClaim != null ? resultMenu.OperationClaim.Name:null,
                            }).ToList();
                return menu;
            }
    }
}

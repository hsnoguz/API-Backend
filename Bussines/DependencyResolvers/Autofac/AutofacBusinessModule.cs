using Autofac;
using Autofac.Extras.DynamicProxy;
using Bussines.Abstract;
using Bussines.Concrete;
using Bussines.Service.Abstract;
using Bussines.Service.Concrete;
using Castle.DynamicProxy;
using Core.Interceptors;
using Core.Utilities.Security.JWT;
using DAL.Abstract;
using Service.Abstract;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
    

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<RefreshTokenService>().As<IRefreshTokenService>();
            builder.RegisterType<EfRefreshTokenDal>().As<IEfRefreshTokenDal>();
            builder.RegisterType<EfPeriotDal>().As<IEfPeriotDal>();
            builder.RegisterType<EfAimDal>().As<IEfAimDal>();
            builder.RegisterType<EfActionDal>().As<IEfActionDal>();
            builder.RegisterType<EfSubActionDal>().As<IEfSubActionDal>();
            builder.RegisterType<EfManualPageDal>().As<IEfManualPageDal>();
            
            //      builder.RegisterType<EfTargetDal>().As<IEfAimDal>();
            builder.RegisterType<EfProjectDal>().As<IEfProjectDal>();
            builder.RegisterType<EfQuestionDal>().As<IEfQuestionDal>();
            builder.RegisterType<EfQuestionHorizontalDal>().As<IEfQuestionHorizontalDal>();
            builder.RegisterType<EfQuestionVerticalDal>().As<IEfQuestionVerticalDal>();
            builder.RegisterType<EfTargetDal>().As<IEfTargetDal>();
            builder.RegisterType<EfUserLeftMenuClaimDal>().As<IEfUserLeftMenuClaimDal>();
            builder.RegisterType<EfSurveyAnalyzeDal>().As<IEfSurveyAnalyzeDal>();

            builder.RegisterType<EfPerformanceDal>().As<IEfPerformanceDal>();
            builder.RegisterType<EfPerformanceTargetResultDal>().As<IEfPerformanceTargetResultDal>();
            builder.RegisterType<EfPeriotDal>().As<IEfPeriotDal>();
            builder.RegisterType<EfActionPriceDal>().As<IEfActionPriceDal>();
            builder.RegisterType<EfQuestionTextTypeDal>().As<IEfQuestionTextTypeDal>();
            
            builder.RegisterType<EfTargetRiskStrategyThreatenedNeedDal>().As<IEfTargetRiskStrategyThreatenedNeedDal>();
            builder.RegisterType<EfOrganizationServiceDal>().As<IEfOrganizationServiceDal>();
            builder.RegisterType<EfOperationServiceDal>().As<IEfOperationServiceDal>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IEfUserOperationClaimDal>();
            builder.RegisterType<EfPerformancePeriotDal>().As<IEfPerformancePeriotDal>();
            builder.RegisterType<EfPerformanceTypeDal>().As<IEfPerformanceTypeDal>();
            builder.RegisterType<EfPerformanceAimDal>().As<IEfPerformanceAimDal>();
            builder.RegisterType<EfPerformanceMatchTargetDal>().As<IEfPerformanceMatchTargetDal>();
            builder.RegisterType<EfLeftMenuDal>().As<IEfLeftMenuDal>();
            builder.RegisterType<EfOperationClaimDal>().As<IEfOperationClaimDal>();
            builder.RegisterType<EfOperationClaimDal>().As<IEfOperationClaimDal>();
            builder.RegisterType<PerformanceTargetResultManager>().As<IPerformanceTargetResultManager>();
            builder.RegisterType<SurveyAnalzeManager>().As<ISurveyAnalzeManager>();

            builder.RegisterType<TargetRiskStrategyThreatenedNeedManager>().As<ITargetRiskStrategyThreatenedNeedManager>();
            builder.RegisterType<ManualPageManager>().As<IManualPageManager>();
            builder.RegisterType<PerformanceMatchTargetManager>().As<IPerformanceMatchTarget>();
            builder.RegisterType<PerformanceManager>().As<IPerformanceManager>();
          //  builder.RegisterType<CookieHelper>().As<ICookieHelper>();
            builder.RegisterType<OperationService>().As<IOperationService>();
            builder.RegisterType<PeriotManager>().As<IPeriotManager>();
           // builder.RegisterType<LeftMenuManager>().As<ILeftMenuManager>();
           // builder.RegisterType<AuthManager>().As<IAuthManager>();
            builder.RegisterType<JopService>().As<IJopService>();
            builder.RegisterType<UserOperationClaim>().As<IUserOperationClaim>();
            builder.RegisterType<BranchService>().As<IBranchService>();
            builder.RegisterType<OrganizationService>().As<IOrganizationService>();
            builder.RegisterType<PerformanceAimService>().As<IPerformanceAimService>();
            builder.RegisterType<PerformanceTypeService>().As<IPerformanceTypeService>();
            builder.RegisterType<PerformancePeriotService>().As<IPerformancePeriotService>();
            builder.RegisterType<ActionPriceManager>().As<IActionPriceManager>();
            builder.RegisterType<LeftMenuManager>().As<ILeftMenuManager>();
            builder.RegisterType<UserLeftMenuClaimManager>().As<IUserLeftMenuClaim>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<ProjectManager>().As<IProjectManager>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<PeriotManager>().As<IPeriotManager>();
            builder.RegisterType<BranchService>().As<IBranchService>();
            builder.RegisterType<JopService>().As<IJopService>();
            builder.RegisterType<SignPeriotManager>().As<ISignPeriot>();
            builder.RegisterType<OrganizationService>().As<IOrganizationService>();
            builder.RegisterType<AimManager>().As<IAimManager>();
            builder.RegisterType<TargetManager>().As<ITargetManager>();
            builder.RegisterType<ActionManager>().As<IActionManager>();
            builder.RegisterType<SubActionManager>().As<ISubActionManager>();
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimManager>();
            builder.RegisterType<QuestionTextTypeService>().As<IQuestionTextTypeService>();
            
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();



    }
    }
}

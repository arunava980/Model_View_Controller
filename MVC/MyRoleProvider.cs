using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MVC
{
    public class MyRoleProvider:RoleProvider
    {
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Removes a role from the data source for the configured applicationName.
        //
        // Parameters:
        //   roleName:
        //     The name of the role to delete.
        //
        //   throwOnPopulatedRole:
        //     If true, throw an exception if roleName has one or more members and do not delete
        //     roleName.
        //
        // Returns:
        //     true if the role was successfully deleted; otherwise, false.
       
        //
        // Summary:
        //     Gets an array of user names in a role where the user name contains the specified
        //     user name to match.
        //
        // Parameters:
        //   roleName:
        //     The role to search in.
        //
        //   usernameToMatch:
        //     The user name to search for.
        //
        // Returns:
        //     A string array containing the names of all the users where the user name matches
        //     usernameToMatch and the user is a member of the specified role.
        public override  string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Gets a list of all the roles for the configured applicationName.
        //
        // Returns:
        //     A string array containing the names of all the roles stored in the data source
        //     for the configured applicationName.
        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Gets a list of the roles that a specified user is in for the configured applicationName.
        //
        // Parameters:
        //   username:
        //     The user to return a list of roles for.
        //
        // Returns:
        //     A string array containing the names of all the roles that the specified user
        //     is in for the configured applicationName.
        public override string[] GetRolesForUser(string username)
        {
            MVC_Authenticate_AuthorizeEntities OE = new MVC_Authenticate_AuthorizeEntities();
            string s = OE.tbl_User.Where(x => x.UserName == username).FirstOrDefault().Role;
            string[] results = { s };
            return results;
        }
        //
        // Summary:
        //     Gets a list of users in the specified role for the configured applicationName.
        //
        // Parameters:
        //   roleName:
        //     The name of the role to get the list of users for.
        //
        // Returns:
        //     A string array containing the names of all the users who are members of the specified
        //     role for the configured applicationName.
        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();

        }
        //
        // Summary:
        //     Gets a value indicating whether the specified user is in the specified role for
        //     the configured applicationName.
        //
        // Parameters:
        //   username:
        //     The user name to search for.
        //
        //   roleName:
        //     The role to search in.
        //
        // Returns:
        //     true if the specified user is in the specified role for the configured applicationName;
        //     otherwise, false.
        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();

        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
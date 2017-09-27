using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Xamarin.Database;

namespace XamarinFirebaseHA
{
	public class DbFirebase
	{
		FirebaseClient client;
		public DbFirebase()
		{
			client = new FirebaseClient("buraya kendi url girin");
		}

		public async Task<List<Student>> getList()
		{
			var list = (await client
				.Child("Student")
				.OnceAsync<Student>())
				.Select(item =>
						new Student
						{
							age=item.Object.age,
							name=item.Object.name
			}).ToList();


			return list;

		}

	}
}

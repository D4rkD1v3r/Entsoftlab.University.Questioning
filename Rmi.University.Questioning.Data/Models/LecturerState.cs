namespace Rmi.University.Questioning.Data.Models
{
	/// <summary>
	/// Статус преподавателя.
	/// </summary>
	public enum LecturerState:short
	{
		/// <summary>
		/// Штатный.
		/// </summary>
		Salaried=0,
		/// <summary>
		/// Внештатный.
		/// </summary>
		Freelance=1<<0,
		/// <summary>
		/// Внутренний совместитель.
		/// </summary>
		InternalPartTime = 1<<1
	}
}
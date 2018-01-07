namespace Entsoftlab.University.Questioning.Data.Models
{
	/// <summary>
	/// 
	/// </summary>
	public enum TeachType : short
	{
		/// <summary>
		/// Очная.
		/// </summary>
		FullTime = 0,
		/// <summary>
		/// Заочная.
		/// </summary>
		Correspondence = 1 << 0,
		/// <summary>
		/// Вечерняя.
		/// </summary>
		Evening = 1 << 1,
		/// <summary>
		/// Дистанционная.
		/// </summary>
		Extramural = 1 << 2
	}
}
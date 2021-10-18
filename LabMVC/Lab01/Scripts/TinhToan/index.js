const amount = $('#amount')
const calBtn = $('#cal-btn')

calBtn.click(async () => {
	const result = await $.get(
		`TinhToan/Calulate?${$("form").serialize()}`
	)
	amount.val(result)
})
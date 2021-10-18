const output = $('#output')

const preNames = ['Plus', 'Minus', 'Multiply', 'Divide']

for (const preName of preNames) {
	$(`#${preName}-btn`).click(async () => {
		try {
			const result = await $.get(
				`ThucHienPhepTinh/${preName}?${$("form").serialize()}`
			)
			output.val(result)
		}
		catch (e) {
			console.log(e)
		}
	})
}
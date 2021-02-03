addEventListener('load', () => {
  dataNowFooter()
})

const dataNowFooter = () => {
  const dataFooter = document.querySelector('#date-footer')

  dataFooter.textContent = new Date().getFullYear()
}
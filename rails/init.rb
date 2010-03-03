%w(
  common/src/rb/lib
  firefox/src/rb/lib
  chrome/src/rb/lib
  jobbie/src/rb/lib
  remote/client/src/rb/lib
).each {|path| $:.unshift File.join(File.dirname(__FILE__), '..', path) }

# Note we just add require paths here, no `require 'selenium-webdriver'` since
# we just want selenium-webdriver be loaded in test/cucumber environment.
